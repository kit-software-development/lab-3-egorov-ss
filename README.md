# Лабораторная работа №3

*По предмету "Технологии разработки программного обеспечения (C#)"*

### Цели работы

1. Научится создавать графический интерфейс пользователя средствами технологии Windows Forms.
2. Научится создавать и использовать комплексные элементы управления (User Controls) для разработки графического интерфейса пользователя.
3. Научится обрабатывать события пользовательского интерфейса.
4. Научится использовать библиотечные элементы управления для разработки графического интерфейса пользователя.
5. Научится позиционировать элементы управления с учётом требований к адаптивности и отзывчивости пользовательского интерфейса.

### Рассматриваемые темы

В рамках настоящей лабораторной работы рассматриваются следующие темы:

1. Графический интерфейс пользователя / Graphic User Interface - GUI;
2. Элементы управления:
   - кнопка (Button);
   - метка (Label);
   - ползунок (Slider);
   - всплывающая подсказка (ToolTip).
3. Обработка событий:
   - события мыши;
   - клавиатурные события;
   - событие нажатия на кнопку.

## Ход работы

В рамках лабораторной работы требуется разработать три приложения. Интерфейс каждого приложения описан прототипом, представляющим собой графическое схематическое изображение окна приложения, с расположенными на нём элементами управления и необходимыми комментариями.

Функционал, который необходимо разработать в рамках лабораторной работы описан в терминах функциональных требований к приложению.

Каждое приложение должно быть выполнено как отдельный проект. Таким образом должны получиться три проекта, размещённые в рамках одного решения. Каждый проект описывает одно приложение.

### Приложение "Убегающая кнопка"

Суть приложения состоит в том, что пользователю предлагается окно, содержащее кнопку. Цель пользователя - нажать на кнопку. Приложение должно не дать пользователю нажать на кнопку.

#### Интерфейс приложения

![Интерфейс приложения "Убегающая кнопка"](https://github.com/kit-software-development/lab-3/blob/master/UI%20Prototypes/Running%20Button.png)

#### Требования к приложению

1. При открытии приложения кнопка позиционируется по центру окна.
2. Окно приложения поддерживает изменение размеров.
3. Окно приложения поддерживает сворачивание на панель задач.
4. Окно приложения поддерживает разворачивание на весь экран.
5. При изменении размеров окна, кнопка изменяет своё положение пропорционально направлению изменения размеров окна.
6. Кнопка не может выйти за пределы окна.
7. При движении мышки в направлении кнопки, кнопка перемещается в сторону, противоположную движению мыши с ускорением, пропорциональным скорости движения курсора мыши.
8. При успешном нажатии на кнопку, приложение открывает диалоговое окно, содержащее сообщение: "Поздравляем! Вы смогли нажать на кнопку!".

### Приложение "Цветовая палитра"

Приложение представляет собой инструмент, позволяющий пользователю выбирать цвет, с использованием графического пользовательского интерфейса.

#### Интерфейс приложения 

![Интерфейс приложения "Цветовая палитра"](https://github.com/kit-software-development/lab-3/blob/master/UI%20Prototypes/Color%20Picker.png)

#### Требования к приложению

>  Элемент управления, представляющий собой прямоугольную область, используемую для вывода цвета, будем называть - **холст**.

1. При открытии приложения кнопка позиционируется по центру окна.
2. Окно приложения поддерживает изменение размеров.
3. Окно приложения поддерживает сворачивание на панель задач.
4. Окно приложения поддерживает разворачивание на весь экран.
5. Расстояние от всех элементов управления (кроме "холста") до правого края окна должно быть постоянным.
6. Расстояния от "холста" до левого, верхнего и нижнего краёв окна должны быть постоянными.
7. При наведении курсора мыши на "холст" должна появляться всплывающая подсказка, содержащая шестнадцатеричный код цвета.
8. При изменении позиций ползунков, цвет "холста" должен изменяться на цвет, соответствующий позициям ползунков.
9. При изменении позиций ползунков, цвет, соответствующий их позициям, должен быть записан в буфер обмена в виде строки, содержащей его шестнадцатеричный код.

#### Взаимодействие с буфером обмена

Для взаимодействия с буфером обмена можно использовать статические методы класса `Clipboard` из пространства имён `System.Windows.Forms`.

Для записи строки в буфер обмена следует вызвать метод `SetText()`. 

```csharp
Clipboard.SetText("#CDCDCD");
```

Для получения данных из буфера обмена можно пользоваться методов `GetText()` того же класса.

```csharp
string color = Clipboard.GetText();
```

Оба метода имеют перегруженные варианты, принимающие дополнительный параметр типа `TextDataFormat`. Тип описан в пространстве имён `System.Windows.Forms` следующим образом.

```csharp
namespace System.Windows.Forms
{
    //
    // Summary:
    //     Specifies the formats used with text-related methods of the 
    //	   System.Windows.Forms.Clipboard and System.Windows.Forms.DataObject classes.
    public enum TextDataFormat
    {
        //
        // Summary:
        //     Specifies the standard ANSI text format.
        Text = 0,
        //
        // Summary:
        //     Specifies the standard Windows Unicode text format.
        UnicodeText = 1,
        //
        // Summary:
        //     Specifies text consisting of rich text format (RTF) data.
        Rtf = 2,
        //
        // Summary:
        //     Specifies text consisting of HTML data.
        Html = 3,
        //
        // Summary:
        //     Specifies a comma-separated value (CSV) format, 
        //	   which is a common interchange
        //     format used by spreadsheets.
        CommaSeparatedValue = 4
    }
}
```

Как можно видеть из описания типа данных, `TextDataFormat` - это перечисление, определяющее, в каком из распространённых форматов описан текст.

### Приложение "Калькулятор"

Приложение представляет собой простейшую версию калькулятора, выполняющего основные арифметические действия.

#### Интерфейс приложения

![Интерфейс приложения "Калькулятор"](https://github.com/kit-software-development/lab-3/blob/master/UI%20Prototypes/Calculator.png)

#### Требования к приложению

> Элемент управления, используемый для отображения вводимых пользователем данных и промежуточных результатов вычислений будем называть **дисплеем** приложения.

1. Приложение должно выполнять сложение чисел.
2. Приложение должно выполнять вычитание чисел.
3. Приложение должно выполнять умножение чисел.
4. Приложение должно выполнять деление чисел.
5. Приложение должно позволять пользователю вводить число с использованием кнопок графического интерфейса пользователя.
6. Приложение должно позволять пользователю вводить число с использованием кнопок клавиатуры.
7. Окно приложения поддерживает сворачиванием на панель задач.
8. Окно приложения не поддерживает разворачивание на весь экран.
9. Окно приложения поддерживает изменение размеров.
10. Окно приложения не позволяет изменять размеры окна более заданного максимального размера.
11. Окно приложения не позволяет изменять размеры окна менее заданного минимального размера.
12. Вводимые пользователем данные отображаются на дисплее приложения.
13. Промежуточные результаты вычислений отображаются на дисплее приложения.
14. Расстояние от дисплея до левого, верхнего и правого края клиентской части пользовательского интерфейса должно быть постоянным.
15. При изменении размеров окна, позиции кнопок и их размеры изменяются пропорционально направлению изменения размера окна.
16. Промежуточные результаты вычислений сохраняются в буфер обмена в виде текста.
