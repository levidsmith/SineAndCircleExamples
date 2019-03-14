/// @description  2019 Levi D. Smith, levidsmith.com
// You can write your code in this editor


lifetime += move_speed * pi / room_speed  

x = objCircleSpawner.x + radius * UNIT * cos(lifetime)
y = objCircleSpawner.y + -1 * radius * UNIT * sin(lifetime)

effect_create_below(ef_smoke, x, y, 0, c_gray)