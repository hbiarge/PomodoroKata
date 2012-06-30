Característica: Parar un pomodoro
	Para la gestión correcta del tiempo
	como usuario
	quiero que el pomodoro se pare cuando termina el tiempo del pomodoro

Escenario: Un pomodoro no termina si no ha sido arrancado previamente
	Dado un pomodoro no iniciado
	Cuando han pasado 26 minutos
	Entonces el pomodoro no ha terminado

Escenario: Un pomodoro termina cuando se agota su tiempo
	Dado un pomodoro iniciado
	Cuando han pasado 26 minutos
	Entonces el pomodoro ha terminado

Escenario: Un pomodoro no termina mientras no se agote su tiempo
	Dado un pomodoro iniciado
	Cuando han pasado 10 minutos
	Entonces el pomodoro no ha terminado
	Y el pomodoro está iniciado
