float circleX;
float circleY;
float b1;
float b2;


void setup(){
 size(640,360);
 circleX= width/2;
 circleY=0;
 b1=5;
 b2=5;
}
 
void draw(){
  //Drawing stuff
  background(0);
  fill(255);
  ellipse(circleX,circleY,20,20);
  //logic
  if ((circleX<0)||(circleX>640)){
    b1=b1*(-1);
   
  }
  if ((circleY<0)||(circleY>360)){

   b2=b2*(-1);
  }
  circleX=circleX+b1;
  circleY=circleY+b2;
  println(circleY);
 
} 
