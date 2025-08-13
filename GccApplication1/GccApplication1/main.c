#define F_CPU 16000000UL
#include <avr/io.h>
#include <util/delay.h>
#include <avr/interrupt.h>

unsigned char UART_Receive(void) {
	while (!(UCSR0A & (1<<RXC0)));
	return UDR0;
}

int main(void) {
	UART_Init(103);
	
	DDRA |= (1 << PA1) | (1 << PA3);
	
	PORTA &= ~((1 << PA1) | (1 << PA3));
	
	while (1) {
		char command = UART_Receive();
		
		switch(command) {
			case 'r': 
			PORTA |= (1 << PA1);
			break;
			
			case 'b': 
			PORTA |= (1 << PA3);
			break;
			
			case 'x':  
			PORTA &= ~((1 << PA1) | (1 << PA3));
			break;
		}
	}
}