ownedCatAndDog = (c,d) =>{
 let [cY,dY] = [0,0]
   if((c-=15)>=0)  cY=1 
   if((c-=9)>=0)   cY=2
   if((d-=15)>=0)  dY=1 
   if((d-=9)>=0)   dY=2
   
   if(c>0) cY+=(c/4)|0
   if(d>0) dY+=(d/5)|0
   
   return [cY,dY]
}
