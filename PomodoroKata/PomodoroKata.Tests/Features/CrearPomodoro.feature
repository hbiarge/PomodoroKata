Característica: Crear un pomodoro
  Para poder gestionar los pomodoros
  como usuario
  quiero poder crear un nuevo pomodoro
 
Escenario: Crear un nuevo pomodoro sin establecer su duración
  Cuando creo un nuevo pomodoro sin especificar su duración
  Entonces la duración del pomodoro es de 25 minutos
  Y el pomodoro está parado
  Y el número de interrupciones es 0

Escenario: Crear un nuevo pomodoro definiendo su duración 
  Cuando creo un nuevo pomodoro espedificando una duración de 30 minutos
  Entonces la duración del pomodoro es de 30 minutos
  Y el pomodoro está parado
  Y el número de interrupciones es 0