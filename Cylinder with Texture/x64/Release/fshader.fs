#version 330 core
out vec4 FragColor;

in vec2 texcoordOut;

uniform sampler2D tex;
void main(){
	/*
	FragColor = vec4(1.0f, 1.0f, 1.0f, 1.0f);
	if(gl_PrimitiveID==0||gl_PrimitiveID==1) 	FragColor = vec4(0.7f, 0.0f, 0.0f, 1.0f);
	if(gl_PrimitiveID==2||gl_PrimitiveID==3) 	FragColor = vec4(0.7f, 0.7f, 0.0f, 1.0f);
	if(gl_PrimitiveID==4||gl_PrimitiveID==5) 	FragColor = vec4(0.0f, 0.7f, 0.7f, 1.0f);
	if(gl_PrimitiveID==6||gl_PrimitiveID==7) 	FragColor = vec4(0.0f, 0.0f, 0.7f, 1.0f);
	if(gl_PrimitiveID==8||gl_PrimitiveID==9) 	FragColor = vec4(0.7f, 0.0f, 0.7f, 1.0f);
	*/
	FragColor = texture(tex, texcoordOut);
}