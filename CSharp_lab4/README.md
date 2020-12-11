## Лабораторная работа №3
### Сделать иерархию классов для вычисления математических выражений.

1. **Базовый абстрактный класс.**

```
abstract Class Expr
{
    public abstract double Compute(IReadOnlyDictionary<string, double> variableValues);

    public abstract IEnumerable<string> Variables { get; protected set;}

    public abstract bool IsConstant { get; }

    public abstract bool IsPolynom { get; }
}
```

2. **Абстрактные классы:**

    - ```UnaryOperation```,
    - ```BinaryOperation```,
    - ```Function```

3. **Классы реализующие арифметические операции:**
     - ```+```,
     - ```-```,
     - ```/```,
     - ```*```,

   **Классы:**
    - ```Variable```, 
    - ```Constant```.

4. **Сделать для этих классов перегрузку операторов.**

5. **Классы реализующие функции:**

    - a. Степенные,
    - b. Тригонометрические,
    - c. Обратные тригонометрические,
    - d. Гиперболические,
    - e. Обратные гиперболические.

6. **Доп. задания**

    - a. Дифференцирование,
    - b. Разбор выражений,
    - c. Упрощение выражений,
    - d. Интегрирование,
    - e. Векторная арифметика,
    - f. Добавление своих функций.
---

## Пример
```
namespace ПЗ3
{
    using static FunctioFabric;
    …
    static class FunctioFabric
{
    public static SinFunc Sin(Expr e) => new SinFunc(e);
}
}

var a = new Variable("a");
var b = new Variable("b");

var expr0 = new Mult(new Add(a, b), new SinFunc(new Divide(a, new Constant(2))));

var expr = (a + b) * Sin(a / 2);

Console.WriteLine(expr);

Console.WriteLine(expr.Compute(new Dictionary<string, double>{["a"] = 5, ["b"] = 3}))

```
