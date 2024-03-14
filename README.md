# LR2

## Prototype

Шаблон проектування Prototype використовується для створення нових об'єктів за допомогою клонування існуючих об'єктів, що є прототипами. Цей шаблон дозволяє створювати нові об'єкти, копіюючи стан існуючого об'єкта, при цьому уникненні прямої залежності від класу цього об'єкта.

### Структура
1. **Prototype (Прототип)**: це абстрактний клас або інтерфейс, який визначає метод клонування.
2. **ConcretePrototype (Конкретний прототип)**: це клас, який реалізує клонування, щоб створювати нові об'єкти.
3. **Client (Клієнт)**: клас або модуль, який використовує прототип для створення нових об'єктів.
![image](https://github.com/batl64/Lr2_Net/blob/main/1.png?raw=true)


### Переваги
- **Зменшення витрат на створення об'єктів**: використання клонування може бути більш ефективним за створення нових об'єктів з нуля.
- **Спрощення коду**: дозволяє уникнути дублювання коду для створення схожих об'єктів.
- **Гнучкість в створенні об'єктів**: можливість динамічно визначати тип створюваних об'єктів.

### Недоліки
- **Складність управління клонуваними об'єктами**: може виникнути необхідність управління станом клонованих об'єктів.
- **Можливість втрати даних**: клонування може привести до неправильного копіювання деяких даних або стану об'єкта.

### Використання
- Коли потрібно створювати об'єкти, схожі за структурою та станом існуючих об'єктів.
- Для уникнення прямих залежностей від класів конкретних об'єктів при створенні нових об'єктів.

Шаблон проектування Prototype дозволяє створювати нові об'єкти шляхом клонування існуючих об'єктів, що дозволяє покращити ефективність та гнучкість управління об'єктами в додатку.

## Composite
Шаблон проектування Composite використовується для створення структурних дерев'яних об'єктів, що представляють ієрархію частин-цілого. Цей шаблон дозволяє клієнтам обробляти окремі об'єкти та їхні складові однаковим чином.

### Структура
1. **Component (Компонент)**: це абстрактний клас або інтерфейс, який описує загальний інтерфейс для всіх класів у дереві компонентів.
2. **Leaf (Лист)**: це клас, який представляє кінцевий елемент у дереві компонентів, який не може мати дочірніх компонентів.
3. **Composite (Композит)**: це клас, який представляє складний елемент у дереві компонентів, який може мати дочірні елементи, які можуть бути як листками, так і іншими композитами.
4. **Client (Клієнт)**: клас або модуль, який використовує компоненти для створення деревовидних структур та виконання операцій з ними.
![image](https://github.com/batl64/Lr2_Net/blob/main/1.png?raw=true)

### Переваги
- **Простота використання**: дозволяє клієнтам однаковим чином обробляти як окремі об'єкти, так і їхні складові частини.
- **Гнучкість структури**: дозволяє динамічно додавати та видаляти компоненти у дереві без зміни коду клієнта.
- **Спрощення коду**: спрощує структуру коду, оскільки дозволяє обробляти цілі групи об'єктів так само, як і окремі об'єкти.

### Недоліки
- **Обмеженість в дизайні**: може бути складніше використовувати, коли потрібно реалізувати деякі специфічні функціональності, що не підходять під структуру дерева.

### Використання
- Коли потрібно представити структуру у вигляді дерева, де кожен елемент може бути окремим об'єктом або групою об'єктів.
- Для реалізації компонентів UI, де кожен елемент може бути окремим елементом або контейнером для інших елементів.
- У моделюванні структур даних, де потрібно працювати зі складними структурами, які складаються з багатьох частин.

Шаблон проектування Composite дозволяє створювати структурні дерев'яні об'єкти, що представляють ієрархію частин-цілого, що полегшує обробку структурних даних та спрощує структуру програмного коду.

## State
Шаблон проектування State використовується для моделювання станів об'єктів і керування поведінкою в залежності від їх поточного стану. Цей шаблон дозволяє об'єкту змінювати свою поведінку в залежності від стану, в якому він перебуває, при цьому зовнішній код не залежить від конкретного стану об'єкта.

### Структура
1. **Context (Контекст)**: це клас, який має внутрішній стан і викликає методи стану для зміни свого стану та поведінки.
2. **State (Стан)**: це абстрактний клас або інтерфейс, який визначає методи, що пов'язані з кожним станом об'єкта.
3. **ConcreteState (Конкретний стан)**: це конкретна реалізація стану, яка визначає поведінку об'єкта в цьому стані.

### Переваги
- **Легкість додавання нових станів**: можливість легко додавати нові стани без зміни коду контексту або інших станів.
- **Розділення відповідальності**: кожен стан відповідає за свою власну поведінку, що спрощує розуміння та підтримку коду.

### Недоліки
- **Збільшення кількості класів**: шаблон може призвести до створення багато класів станів, що може ускладнити структуру програми.

### Використання
- Коли об'єкт може змінювати свою поведінку в залежності від свого стану.
- Для реалізації складних алгоритмів, що можуть мати різні стани в різних частинах або моментах виконання.

Шаблон проектування State дозволяє моделювати складну поведінку об'єктів за допомогою розділення їх станів на окремі класи, що дозволяє покращити розширюваність та підтримку коду.

## Double-checked locking
Double-checked locking є шаблоном проектування, який використовується для зменшення витрат на синхронізацію при доступі до ресурсів, що можуть бути ініціалізовані не за всіма потрібними чи вже існуючими даними. Цей шаблон використовує подвійну перевірку за умови, щоб уникнути накладних витрат на блокування в тих випадках, коли ініціалізація вже відбулася або ще не потрібна.

### Структура
1. **Singleton (Одиничка)**: клас, для якого застосовується double-checked locking. Зазвичай це клас, який має один екземпляр і доступ до нього повинен бути потокобезпечним.
2. **Клієнт (Client)** - використовує екземпляр типу Одиничка.
### Діаграма класів 
![image](https://github.com/batl64/Lr2_Net/blob/main/4.png?raw=true)

### Переваги
- **Ефективність**: зменшення витрат на синхронізацію для випадків, коли ініціалізація вже відбулася.
- **Лінива ініціалізація**: об'єкт створюється тільки тоді, коли він дійсно потрібен.

### Недоліки
- **Складність коду**: потреба вручну управляти подвійною перевіркою може призвести до складності коду і потенційних помилок.

Double-checked locking є потужним шаблоном проектування для створення потокобезпечних сінглтонів та зниження витрат на синхронізацію у випадках, коли ініціалізація об'єкта може бути відкладеною або незаданою.



## Джерело: розмова,
1. Object Pool Design Pattern - Definition & Examples | Pentalog. https://www.pentalog.com/blog/design-patterns/object-pool-design-pattern/.
2. Object Pool Design Pattern - GeeksforGeeks. https://www.geeksforgeeks.org/object-pool-design-pattern/.
3. Object Pool Design Pattern | CodingDrills. https://www.codingdrills.com/tutorial/design-patterns-tutorial/object-pool-pattern.
4. Object Pool Design Pattern - Medium. https://medium.com/@aainajain/object-pool-design-pattern-9e5d0d53fa26.
