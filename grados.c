#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
#include <ctype.h>



int main(int argc, char *argv[])
{
	
	int sock_conn, sock_listen, ret;
	struct sockaddr_in serv_adr;
	char peticion[512];
	char respuesta[512];
	//Abrimos el socket
	if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
		printf("Error creant socket");

	//Inicicaliza a cero serv_addr
	memset(&serv_adr, 0, sizeof(serv_adr));
	serv_adr.sin_family = AF_INET;
	
	//Asocia el socket a cualquiera de las IP de la maquina 
	//Con htonl formatea el numero que recibe al formato necesario
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);
	
	//Establecemos el puerto de escucha
	serv_adr.sin_port = htons(9070);
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf ("Error al bind");
	
	if (listen(sock_listen, 3) < 0)
		printf("Error en el Listen");
	
	int i;
	//Usamos un bucle infinito
	for (;;){
		printf ("Escuchando\n");
		
		//El socket que usaremos para este cliente es sock_conn
		sock_conn = accept(sock_listen, NULL, NULL);
		printf ("He recibido conexion\n");
		
		
		int terminar =0;
		//Bucle para atender todas las peticiones del cliente hasta su desconexion
		while (terminar ==0)
		{
			//Recibimos la peticion
			ret=read(sock_conn,peticion, sizeof(peticion));
			printf ("Recibido\n");
			
			//Marca de fin de string para quitar la redundancia que haya acumulado durante el camino 
			peticion[ret]='\0';
			
			
			printf ("Peticion: %s\n",peticion);
			
			//Miramos cual es la peticion
			char *p = strtok( peticion, "/");
			int codigo =  atoi (p);
			*p = strtok(peticion, "/");
			float grados= atof(p);
			
			if (codigo !=0)
			{
				p = strtok( NULL, "/");

				//Obtenemos los grados
				strcpy (grados, p);
				printf ("Codigo: %d, Nombre: %s\n", codigo, grados);
			}
			
			 //Cuando el codigo es 0, se trata de una peticion de desconexion
			if (codigo ==0)
				terminar=1;					 
			//Cuando el codigo es 1, quiero pasar de Celcius a Farenheit
			else if (codigo ==1)
				respuesta = ((gra*1.8)+32);
			//Cuando el codigo es 2, quiero pasar de Farenheit a Celcius
			else
				respuesta=((grados-32)*1.8);
			
			if (codigo !=0)
			{				
				printf ("Respuesta: %s\n", respuesta);
				//Enviamos la respuesta
				write (sock_conn,respuesta, strlen(respuesta));
			}
		}
		//Fin de servicio para este cliente
		close(sock_conn); 
	}
}
