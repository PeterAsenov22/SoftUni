function radar([speed,area]) {
    let limit = getLimit(area);
    let infraction = getInfraction(speed,limit);

    if(infraction != false){
        return infraction;
    }

    function getInfraction(speed,limit) {
        if(speed <= limit){
             return false;
         }
        else{
             let overLimit = speed - limit;
             if(overLimit <= 20){
                 return 'speeding';
             }
             else if(overLimit > 20 && overLimit <= 40){
                 return 'excessive speeding';
             }
             else {
                 return 'reckless driving';
             }
         }
     }

    function getLimit(zone) {
       switch(zone.toLowerCase()){
           case 'motorway' : return 130;
           case 'interstate' : return 90;
           case 'city' : return 50;
           case 'residential' : return 20;
       }
   }
}
