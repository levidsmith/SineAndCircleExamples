/// @description 2019 Levi D. Smith, levidsmith.com
// You can write your code in this editor


lifetime += pi * UNIT / room_speed  

x = objSineSpawner.x + lifetime
y = -1 * sin(lifetime * frequency / UNIT) * amplitude + objSineSpawner.y //multiply by -1 since GameMaker uses y down coordinates

effect_create_below(ef_smoke, x, y, 0, c_gray)