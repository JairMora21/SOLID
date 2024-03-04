Créditos al curso [Principios SOLID](https://www.youtube.com/playlist?list=PLWYKfSbdsjJjk_kK-fYcjoYF_TS8_kysZ) hecho por Héctor de Leon en YouTube

### Elementos complementarios 
Documentacion adicional y mas detallada de cada principio SOLID [(Doc Word)](https://1drv.ms/w/s!AgoIQHtvH_IShblvj4yqer5q26eyow?e=Nt3cC0).


# Patrones de diseño
#### ¿Que es SOLID?
SOLID es un acrónimo que representa un conjunto de cinco principios de diseño de software orientado a objetos. Estos principios fueron introducidos por Robert C. Martin y se centran en mejorar la modularidad y la mantenibilidad del código
Significado de cada letra 

- S: Single Responsability

- O: Open and Close

- L: Liskov Subsitution

- I: Interface segregation

- D: Dependency Inversion

## Principios en repasados en este repositorio
> Haga 'clic' en el nombre del principio para acceder a los archivos en el repositorio
### [Single Responsability](https://github.com/JairMora21/SOLID/blob/master/SingleResponsability/Beer.cs)
Este principio nos menciona que una clase solo debe tener una responsabilidad, esto ayuda a que si nosotros necesitamos hacer un cambio a esa responsabilidad o funcionamiento del requerimiento solamente tengas que ir a un sitio


### [Open And Close](https://github.com/JairMora21/SOLID/blob/master/OpenClose/OpenClose.cs) 
Es dejar una entidad de software (una clase, una función) debe quedar abierta para su extensión pero cerrada para su modificación. Una ves terminas una clase esta clase no debería editarse (en teoría) pero si puede extender su funcionamiento 

### [Liskov](https://github.com/JairMora21/SOLID/tree/master/Liskov)
Este principio nos dice que si tienes una clase padre, la cual hereda a una clase hija, la hija no debe alterar el funcionamiento del padre 
Cada clase hija de otra clase puede utilizarse como su padre sin necesidad de conocer diferencia entre quien sea su padre, es decir que una hija puede sustituir al padre y esto no implicaría problema en el software.

### [Interface Segregation](https://github.com/JairMora21/SOLID/blob/master/InterfaceSegregation/InterfaceSeg.cs)
La segregación de interfaces es la practica de no tener interfaces muy grandes una interfaz es un contrato y si tu contrato tiene muchos anexos como métodos, propiedades a implementar puede ser contraproducente ya que nos enfrentaremos a clases que van a implementar estas funciones las cuales podrían sobrarle múltiples anexos, esto va muy de la mano con Liskov pero recordemos que liskov se basa con clases y herencia y aquí estamos hablando de interfaces 

### [Dependency Inversion](https://github.com/JairMora21/SOLID/blob/master/DependencyInversion/DependencyInv.cs) 
Este principio nos dice que los módulos de alto nivel no deben depender de los módulos de bajo nivel 
Nos sirve para desacoplar los módulos, componentes, clases 
