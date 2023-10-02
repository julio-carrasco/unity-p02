# unity-p02

![video](https://github.com/julio-carrasco/unity-p02/blob/main/2023-10-03%2000-15-48.gif)

En esta practica he realizado varios scripts y se ha trabajado con el concepto de tags para diferenciar objetos, lo mas visual de esta practica es la diferencia de las posiciones de los objetos y los colores cuando estamos en el editor a cuando ejecutamos la escena.
Lo primero que pasa es que el cubo y el cilindro se colocan a +5 y -5 unidades en el eje x respecto a la esfera respectivamente. Ademas al pulsar la tecla a y la flecha hacia arriba podemos cambiarles los colores.
Finalmente las otras esferas añadidas sufren 2 cambios, el primero es que la mas lejana al cubo cambia de color y la mas cercana se eleva respecto a las otras, lo que pasa es que estos calculos se realizan con el cubo en su posicion original por lo que cuando se ejecuta la escena el cubo se mueve pero las esferas han cambiado teniendo en cuenta la posicion original del cubo.
