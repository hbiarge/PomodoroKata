Característica: Interrumpir pomodoro
	Para gestionar las interrupciones durante un pomodoro
	como usuario
	quiero poder interrumpir un pomodoro

Escenario: No se puede interrumpir un pomodoro no iniciado
	Dado un pomodoro no iniciado
	Cuando lo interrumpo
	Entonces el número de interrupciones es 0

Escenario: El pomodoro cuenta las interrupciones
	Dado un pomodoro iniciado
	Cuando lo interrumpo
	Entonces el número de interrupciones es 1
