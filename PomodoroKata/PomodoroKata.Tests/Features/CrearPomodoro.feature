Feature: Crear un pomodoro
  Para poder gestionar los pomodoros
  como usuario
  quiero poder crear un nuevo pomodoro
 
Scenario: Crear un nuevo pomodoro sin establecer su duración
  Given No se ha creado todavía un pomodoro
  When Creo un nuevo pomodoro sin especificar su duración
  Then la duración del pomodoro es de 25 minutos
  And el pomodoro está parado

Scenario: Crear un nuevo pomodoro definiendo su duración 
  Given No se ha creado todavía un pomodoro
  When Creo un nuevo pomodoro espedificandouna duración de 30 minutos
  Then la duración del pomodoro es de 30 minutos
  And el pomodoro está parado 