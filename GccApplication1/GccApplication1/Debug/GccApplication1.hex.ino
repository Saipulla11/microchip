#define F_CPU 16000000UL // Тактовая частота 16 МГц
#include <avr/io.h>
#include <util/delay.h>

int main(void) {
	// Настраиваем PA1 и PA3 как выходы
	DDRA |= (1 << PA1) | (1 << PA3);

	while (1) {
		// Включаем PA1, выключаем PA3
		PORTA |= (1 << PA1);
		PORTA &= ~(1 << PA3);
		_delay_ms(500);

		// Включаем PA3, выключаем PA1
		PORTA |= (1 << PA3);
		PORTA &= ~(1 << PA1);
		_delay_ms(500);
	}
}