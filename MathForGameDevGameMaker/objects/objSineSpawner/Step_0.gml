/// @description  2019 Levi D. Smith, levidsmith.com
// You can write your code in this editor

spawn_countdown -= 1
if (spawn_countdown < 0) {
	o = instance_create_layer(x, y, "Instances", objSine)
	o.amplitude = amplitude * UNIT
	o.frequency = frequency
	spawn_countdown = 0.5 * pi * room_speed

}

//amplitude = 5
if (keyboard_check_pressed(ord("W"))) {
	amplitude += 1
	if (amplitude > 5) {
		amplitude = 5	
	}
} else if (keyboard_check_pressed(ord("S"))) {
	amplitude -= 1
	if (amplitude < 0) {
		amplitude = 0
	}


} else if (keyboard_check_pressed(ord("D"))) {
	frequency += 0.5
	if (frequency > 4) {
		frequency = 4
	}

} else if (keyboard_check_pressed(ord("A"))) {
	frequency -= 0.5
	if (frequency < 0.5) {
		frequency = 0.5
	}

}

if (keyboard_check_pressed(vk_space)) {
	room_goto_next()	
}