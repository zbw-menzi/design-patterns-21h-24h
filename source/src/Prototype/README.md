# Prototyp Pattern
Neue Instanzen werden auf Grundlage von prototypischen Instanzen („Vorlagen“) erzeugt. Dabei wird die Vorlage kopiert und an neue Bedürfnisse angepasst.

## Problem
Wie kann sehr ähnliche, jedoch teuer zu instanziierende, Objekte einfach erzeugen ohne grosse parallele Factory-Hierachien aufzubauen.

## Lösung
Erstelle ein Interface mit einer clone()-Methode und verlagere die Objektinstaziierung in die Implementierung der konkreten Subtypen.

## UML
```mermaid
classDiagram
    class Prototype
    <<interface>> Prototype
    Prototype: +clone()
    Prototype <|-- ConcretePrototype1
    Prototype <|-- ConcretePrototype2
    class ConcretePrototype1{
      +clone()
    }
    class ConcretePrototype2{
      +clone()
    }
```

## Meine Lösung
Mit ICloneable

```mermaid
classDiagram
    class ICloneable{
        
    }
    <<interface>> ICloneable
    ICloneable <|-- BasicCustomerPrototype
    class BasicCustomerPrototype{
        +String FirstName
        +String Lastname
        +Address HomeAddress
        +Address BillingAddress
    }
    BasicCustomerPrototype: +Clone()
    BasicCustomerPrototype: +DeepClone()
    BasicCustomerPrototype <|-- Customer
    class Customer{
        +Clone()
        +DeepClone()
    }
    Customer <|-- Address
    class Address{
      +String StreetAddress
      +String City
      +String State
      +String Country
      +String PostCode
    }
```


Source:
* https://en.wikipedia.org/wiki/Prototype_pattern
* https://refactoring.guru/design-patterns/prototype