Feature: Iniciar pomodoro
	Para iniciar un pomodoro
	Como usuario
	Quiero poder iniciar un pomodoro

Scenario: Puedo iniciar un pomodoro parado
	Given Un pomodoro no iniciado
	When lo inicio
	Then el pomodoro está iniciado

Scenario: Si inicio un pomodoro iniciado no pasa nada
	Given Un pomodoro iniciado
	When lo inicio
	Then el pomodoro está iniciado
