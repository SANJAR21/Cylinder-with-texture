#version 330 core
layout(location = 0) in vec3 vertexPosition_modelspace;
layout(location = 1) in vec2 texcoord;

uniform mat4 model;
uniform mat4 view;
uniform mat4 projection;

out vec2 texcoordOut;

void main(){
	gl_Position = projection * view * model * vec4(vertexPosition_modelspace,1.0f);
	texcoordOut = texcoord;
}