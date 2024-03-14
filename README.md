# LR2

## Prototype

Шаблон проектування Prototype використовується для створення нових об'єктів за допомогою клонування існуючих об'єктів, що є прототипами. Цей шаблон дозволяє створювати нові об'єкти, копіюючи стан існуючого об'єкта, при цьому уникненні прямої залежності від класу цього об'єкта.

### Структура
1. **Prototype (Прототип)**: це абстрактний клас або інтерфейс, який визначає метод клонування.
2. **ConcretePrototype (Конкретний прототип)**: це клас, який реалізує клонування, щоб створювати нові об'єкти.
3. **Client (Клієнт)**: клас або модуль, який використовує прототип для створення нових об'єктів.

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

## Bridge
Шаблон проектування Bridge використовується для розділення ієрархії класів від їхньої реалізації, дозволяючи їм змінюватися незалежно один від одного. Цей шаблон відокремлює абстракцію від її реалізації так, щоб вони могли змінюватися незалежно одна від одної.

### Структура
1. **Abstraction (Абстракція)**: це інтерфейс або абстрактний клас, який визначає базовий функціонал і містить посилання на об'єкт типу Implementor.
2. **Refined Abstraction (Вдосконалена абстракція)**: це конкретна реалізація абстракції, яка розширює функціонал базового класу.
3. **Implementor (Реалізатор)**: це інтерфейс або абстрактний клас, який визначає методи, що будуть реалізовані конкретними класами.
4. **Concrete Implementor (Конкретний реалізатор)**: це конкретна реалізація реалізатора, яка виконує методи, визначені в інтерфейсі Implementor.

### Діаграма класів 
![image](https://github.com/batl64/Lr2_Net/blob/main/2.png?raw=true)

### Переваги
- **Розділення абстракції від реалізації**: дозволяє змінювати і абстракцію, і реалізацію незалежно одна від одної.
- **Покращена розширюваність**: можливість легко додавати нові абстракції та реалізації без зміни існуючого коду.
- **Зменшення залежностей**: клієнтський код залежить тільки від абстракції, не прив'язуючись до конкретних реалізацій.

### Недоліки
- **Поява додаткових класів**: шаблон може призвести до створення більшої кількості класів, що може ускладнити розуміння коду.

### Використання
- Коли потрібно мати змогу змінювати як абстракцію, так і реалізацію незалежно одна від одної.
- Коли ви хочете підтримувати кілька варіантів реалізації для клієнтів.

Шаблон проектування Bridge дозволяє створювати більш гнучкі та розширювані системи, а також спрощує підтримку коду через його розділення на рівні абстракції та реалізації.

## Specification
Шаблон проектування Specification використовується для опису бізнес-правил, які визначають, чи задовольняє об'єкт певні критерії. Цей шаблон дозволяє розділити логіку перевірки умов на окремі об'єкти, що спрощує їх перевикористання та підтримку.

### Структура
1. **Specification (Специфікація)**: це інтерфейс або абстрактний клас, що визначає метод, за допомогою якого можна перевірити, чи задовольняє об'єкт певні критерії.
2. **Composite Specification (Конкретна специфікація)**: це конкретна реалізація специфікації, яка визначає конкретні умови, які повинен виконувати об'єкт.
3. **Concrete Specification (Об'єкт)**:  це конкретні класи, який реалізують Composite Specification і визначають конкретні бізнес-правила.

### Діаграма класів 
![image](https://github.com/batl64/Lr2_Net/blob/main/3.png?raw=true)

### Переваги
- **Розділення бізнес-правил**: дозволяє визначати правила в окремих класах, що полегшує їх розширення та підтримку.
- **Підтримка складних умов**: можливість комбінувати різні специфікації для створення складних умов перевірки.
- **Підвищення повторного використання**: специфікації можна використовувати у різних частинах системи для перевірки об'єктів за однаковими критеріями.

### Недоліки
- **Збільшення кількості класів**: шаблон може призвести до створення багато класів специфікацій, що може ускладнити структуру програми.

### Використання
- Перевірка умов для відбору об'єктів з колекції.
- Визначення правил для фільтрації даних у додатках.
- Управління доступом до функціоналу на основі умов.

Шаблон проектування Specification дозволяє створювати більш гнучкі та розширювані системи, які можуть ефективно використовувати бізнес-правила для відбору об'єктів за заданими критеріями.

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
