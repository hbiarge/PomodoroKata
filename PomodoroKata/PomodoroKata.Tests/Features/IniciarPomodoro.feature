Característica: Iniciar pomodoro
	Para iniciar un pomodoro
	como usuario
	quiero poder iniciar un pomodoro

Escenario: Puedo iniciar un pomodoro parado
	Dado un pomodoro no iniciado
	Cuando lo inicio
	Entonces el pomodoro está iniciado

Escenario: Si inicio un pomodoro iniciado no pasa nada
	Dado un pomodoro iniciado
	Cuando lo inicio
	Entonces el pomodoro está iniciado
