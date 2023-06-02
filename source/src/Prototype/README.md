# Prototyp Pattern

## Problem

## Lösung

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
        +clone()
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