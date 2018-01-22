function moviePrices(input) {
let film = input[0];
let day = input[1];

if(day.toLowerCase() == 'monday'){
    switch(film.toLowerCase()){
        case "the godfather":
            return 12;
        case "schindler's list":
            return 8.50;
        case "casablanca":
            return 8;
        case "the wizard of oz":
            return 10;
        default:
            return "error";
    }
}
else if(day.toLowerCase() == 'tuesday'){
    switch(film.toLowerCase()){
        case "the godfather":
            return 10;
        case "schindler's list":
            return 8.50;
        case "casablanca":
            return 8;
        case "the wizard of oz":
            return 10;
        default:
            return "error";
    }
}
else if(day.toLowerCase() == 'wednesday'){
        switch(film.toLowerCase()){
            case "the godfather":
                return 15;
            case "schindler's list":
                return 8.50;
            case "casablanca":
                return 8;
            case "the wizard of oz":
                return 10;
            default:
                return "error";
        }
}
else if(day.toLowerCase() == 'thursday'){
    switch(film.toLowerCase()){
        case "the godfather":
            return 12.50;
        case "schindler's list":
            return 8.50;
        case "casablanca":
            return 8;
        case "the wizard of oz":
            return 10;
        default:
            return "error";
    }
}
else if(day.toLowerCase() == 'friday'){
    switch(film.toLowerCase()){
        case "the godfather":
            return 15;
        case "schindler's list":
            return 8.50;
        case "casablanca":
            return 8;
        case "the wizard of oz":
            return 10;
        default:
            return "error";
    }
}
else if(day.toLowerCase() == 'saturday'){
    switch(film.toLowerCase()){
        case "the godfather":
            return 25;
        case "schindler's list":
            return 15;
        case "casablanca":
            return 10;
        case "the wizard of oz":
            return 15;
        default:
            return "error";
    }
}
else if(day.toLowerCase() == 'sunday'){
    switch(film.toLowerCase()){
        case "the godfather":
            return 30;
        case "schindler's list":
            return 15;
        case "casablanca":
            return 10;
        case "the wizard of oz":
            return 15;
        default:
            return "error";
    }
}
else{
    return 'error';
}
}
