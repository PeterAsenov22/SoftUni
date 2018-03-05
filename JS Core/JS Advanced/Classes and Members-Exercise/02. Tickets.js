function tickets(array,criteria) {
    class Ticket{
        constructor(destination,price,status){
            this.destination = destination;
            this.price = parseFloat(price);
            this.status = status;
        }
    }

    let ticketsDatabase = [];

    for (let string of array) {
        let args = string.split('|');
        let ticket = new Ticket(args[0],args[1],args[2]);
        ticketsDatabase.push(ticket);
    }

    switch(criteria){
        case 'destination':
            ticketsDatabase.sort((a,b)=>a.destination.localeCompare(b.destination));
            break;
        case 'status':
            ticketsDatabase.sort((a,b)=>a.status.localeCompare(b.status));
            break;
        case 'price':
            ticketsDatabase.sort((a,b)=>a.price - b.price);
            break;
    }

    return ticketsDatabase;
}
