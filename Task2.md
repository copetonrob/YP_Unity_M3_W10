# Задание 2: Собираем и бросаем корм

## Описание

В этом задании мы реализуем механику бросания корма. Если корм попадает в животного, то оно немного увеличивается в размерах.

## Инструкция

Создадим префаб кусочка корма.

Добавь в проект скрипт для бросания корма [FoodLauncher.cs](https://github.com/copetonrob/YP_Unity_M3_W10/blob/main/FoodLauncher.cs)

В объекте Player уже есть объект FoodLauncher. Навесь на этот объект скрипт FoodLauncher.cs

<img src="https://github.com/copetonrob/YP_Unity_M3_W10/blob/main/img/FoodLauncher.png" width="400"/>

Этому скрипту необходимо указать ссылку на префаб кусочка корма

<img src="https://github.com/copetonrob/YP_Unity_M3_W10/blob/main/img/FoodPrefabRef.png" width="400"/>

Для этого создадим префаб корма.

Создай в сцене новый объект сферу

<img src="https://github.com/copetonrob/YP_Unity_M3_W10/blob/main/img/Sphere.png" width="400"/>

Создай материал для корма. Добавь материал на сферу. Добавь компонент Rigidbody. В компоненте выстави 
Interpolate -> Interpolate 
и 
Collision Detection -> Continous

<img src="https://github.com/copetonrob/YP_Unity_M3_W10/blob/main/img/Components.png" width="400"/>

Создай в проекте скрипт [Food.cs](https://github.com/copetonrob/YP_Unity_M3_W10/blob/main/Food.cs)

Как всега расскомментируй строки и исправь фрагменты с кодом.

Накинь скрипт на объект корма

Перекинь корм в папку проекта, чтобы создать префаб

<img src="https://github.com/copetonrob/YP_Unity_M3_W10/blob/main/img/Prefabs.png" width="400"/>

Закинь префаб корма в FoodLauncher

<img src="https://github.com/copetonrob/YP_Unity_M3_W10/blob/main/img/AddFoodPrefab.png" width="400"/>

Настрой подходящие параметры в скрипте Animal. Пример параметров:

<img src="https://github.com/copetonrob/YP_Unity_M3_W10/blob/main/img/Params.png" width="400"/>

Запусти проект, проверь что все работает.
