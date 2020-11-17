import std.stdio;

//Program done in D Language

void main(string[] args)
{
	int num;
	write("Give me a number: ");
	readf("%s\n", &num);
	//int num = 294;
	int repeticiones = 0;

	writeln("El numero inicial es: ", num);
	

	while (num > 9)
	{
		int producto = 1;
	  
	    while(num != 0){
	    
	    	int unidades = num % 10;
		producto *= unidades;
		num = (num - unidades)/10;
	    
	    
	    }
	
	    repeticiones++;
	    writeln("Producto ", repeticiones, " es: ", producto);
	    num = producto;
	

	}

	
	writeln("la persistencia Multiplicativa es: ", repeticiones, ", cifra final: ", num);
}
