Feature: Interrumpir pomodoro
	Para gestionar las interrupciones durante un pomodoro
	como usuario
	quiero poder interrumpir un pomodoro

Scenario: No se puede interrumpir un pomodoro no iniciado
	Given Un pomodoro no iniciado
	When lo interrumpo
	Then el número de interrupciones es 0

Scenario: El pomodoro cuenta las interrupciones
	Given Un pomodoro iniciado
	When lo interrumpo
	And lo interrumpo
	Then el número de interrupciones es 2
