//Calculate the area of a triangle using Heron's formula
function triangle_area(aa,bb,cc){
	var a = new Number(aa);
	var b = new Number(bb);
	var c = new Number(cc);
	
	var s = (0.5)*(a + b + c);
	var ayy = Math.sqrt(s*(s-a)*(s-b)*(s-c));
	
	return ayy;
};

function calculate(){
	var x = document.getElementById("length_a").value;
	var y = document.getElementById("length_b").value;
	var z = document.getElementById("length_c").value;
	
	var a = triangle_area(x,y,z);
	
	//display area	
	document.getElementById("answer").value = a;
};

function draw(){	
	var a = document.getElementById("length_a").value;
	var b = document.getElementById("length_b").value;
	var c = document.getElementById("length_c").value;
	
	var theta_c; //The angle between b and a
	var theta_b; //The angle between c and a
	var theta_a; //The angle between b and c
	
	var canvas = document.getElementById("myCanvas");
	var ctx = canvas.getContext("2d");

	//clear any previous triangles
	ctx.clearRect(0,0,canvas.width,canvas.height);
	
	//Calculate angles
	var duma= Math.pow(c,2)-Math.pow(a,2)-Math.pow(b,2);//To simplify the expression
	theta_c = Math.acos(duma/(-2*a*b)); //Law of cosines
	theta_b = Math.asin( b * Math.sin(theta_c) / c); //Law of sines
	theta_a = Math.PI - theta_b - theta_c;
	
	var factor = 225.0 //scaling factor
	
	//scale relative to a
	b = factor * (b/a);
	c = factor * (c/a);
	a = factor;
	
	/*Calculate the x and y coordinates of 
	the intersection of b and c*/
	var y_b = b * Math.sin(theta_c);
	var y_a = b * Math.cos(theta_c);
	
	//draw side a
	ctx.beginPath();
	ctx.moveTo(50,350);
	ctx.lineTo(factor+50,350);
	ctx.stroke();
	
	//draw side b
	ctx.moveTo(50,350);
	ctx.lineTo(y_a+50,350-y_b);
	ctx.stroke();
	
	//draw side c
	ctx.lineTo(factor+50,350);
	ctx.stroke();
	ctx.closePath();
	
	//fill in the triangle
	ctx.fillStyle = "red";
	ctx.fill();
	
	//Add labels
	ctx.font = "15px Arial";
	ctx.fillText("a",(factor+50)*0.5,375);
	ctx.fillText("b",0.5*(50+y_a),350-0.5*y_b);
	ctx.fillText("c",0.5*(y_a+factor+100)+10,350-0.5*y_b-10);
	
	//display angles
	document.getElementById("theta_c").value = theta_c;
	document.getElementById("theta_b").value = theta_b;
	document.getElementById("theta_a").value = theta_a;
};

function main(){
	calculate();
	draw();
};