/// @description  2019 Levi D. Smith, levidsmith.com
// You can write your code in this editor

spawn_countdown -= 1
if (spawn_countdown < 0) {
	o = instance_create_layer(x, y, "Instances", objCircle)
	o.radius = radius
	o.move_speed = move_speed
//	spawn_countdown = pi * room_speed
	spawn_countdown = 5 * room_speed

}

//amplitude = 5
if (keyboard_check_pressed(ord("W"))) {
	radius += 1
	if (radius > 5) {
		radius = 5	
	}
} else if (keyboard_check_pressed(ord("S"))) {
	radius -= 1
	if (radius < 0) {
		radius = 0
	}


} else if (keyboard_check_pressed(ord("D"))) {
	move_speed += 0.2
	if (move_speed > 2) {
		move_speed = 2
	}

} else if (keyboard_check_pressed(ord("A"))) {
	move_speed -= 0.2
	if (move_speed < -2) {
		move_speed = -2
	}

}

if (keyboard_check_pressed(vk_space)) {
	room_goto(0)
}

if (keyboard_check_pressed(vk_escape)) {
	instance_destroy(objCircle)
}