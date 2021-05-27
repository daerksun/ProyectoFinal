//	Proyecto Final

/* Linux */
#include <linux/types.h>
#include <linux/input.h>
#include <linux/hidraw.h>
#ifndef HIDIOCSFEATURE
#warning Please have your distro update the userspace kernel headers
#define HIDIOCSFEATURE(len)    _IOC(_IOC_WRITE|_IOC_READ, 'H', 0x06, len)
#define HIDIOCGFEATURE(len)    _IOC(_IOC_WRITE|_IOC_READ, 'H', 0x07, len)
#endif
/* Unix */
#include <sys/ioctl.h>
#include <sys/types.h>
#include <sys/stat.h>
#include <fcntl.h>
#include <unistd.h>
/* C */
#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <errno.h>
#include <pthread.h>
#include <semaphore.h>
#include <syslog.h>
#include <signal.h>
#include <time.h>

int main(void) {

	//Variables que se usaran en el programa

        FILE *temporal = NULL;
        struct timespec t0, t1;
	double tiempoMedido;
        char rm[200], Unit[100];
        int fd, i, res;
	char buf[256], aux[256];

	// Se leeran dos archivos, el primero es el HID del joystick, y el segundo es un archivo 
	// generado en Unity posterior al trabajo del diver

	char *device = "/dev/hidraw2";
    	strcpy(Unit,"/home/daerksun/Documentos/LaSalle/SO2/ProyFinal/t.txt");

    	//Abrimos el dispositivo con lectura HID

	fd = open(device, O_RDWR);
	if (fd < 0) 
	{
		perror("Unable to open device");
		return 1;
	}
	memset(buf, 0x0, sizeof(buf));
	memset(aux, 0x0, sizeof(aux));

	// Obtenemos reporte del dispositivo y lo guardamos en un aux 

	res = read(fd, buf, 16);
	if (res < 0)
		perror("read");
	strcpy(aux, buf);

	// Hay dos de los espacios en el buffer que representan el movimiento del Joystick 
	// especificamente, el 1 y el 4, por lo que leemos hasta que exista algun cambio

	while (buf[1] == aux[1] && buf[4] == aux[4])
	{
		res = read(fd, buf, 16);
		for (i = 0; i < res; i++)
			printf("%hhx ", buf[i]);
		puts("\n");
	}

	// Despues de detectar un movimiento se incia a tomar el tiempo (tick-tock)

	if(clock_gettime(CLOCK_MONOTONIC,&t0) != 0)
	{
		printf("Error al llamar clock_gettime para t0\n");
		exit(EXIT_FAILURE);
	}

	close(fd);

	// Esperamos a que se cree un archivo que nos indicara el fin del procesamiento 
	// del driver en Unity

	printf("Esperando Señal Unity. . .\n");
	while(temporal == NULL)
	{
	       	temporal = fopen(Unit, "r");	        	
	}

	// Paramos y medimos el tiempo
	
	if(clock_gettime(CLOCK_MONOTONIC, &t1) != 0)
	{
		printf("Error al llamar clock_gettime para t1\n");
		exit(EXIT_FAILURE);
	}

	tiempoMedido = (double)(t1.tv_sec - t0.tv_sec) + ((double)(t1.tv_nsec - t0.tv_nsec)/1000000000L);
	printf("Tiempo transcurrido: %lf segundos\n",tiempoMedido);

	//Se remueve el archivo de bandera

	sprintf(rm,"rm %s", Unit);
	system(rm);

	//Se cierra nustro archivo temporal

	fclose(temporal);
}