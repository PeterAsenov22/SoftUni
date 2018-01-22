function distance([v1,v2,seconds]) {
   let distance1 = (v1*1000)/3600 * seconds;
   let distance2 = (v2*1000)/3600 * seconds;

   console.log(Math.abs(distance1 - distance2));
}
