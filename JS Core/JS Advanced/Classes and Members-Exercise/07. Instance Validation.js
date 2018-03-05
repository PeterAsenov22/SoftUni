class CheckingAccount{
    constructor(clientId,email,firstName,lastName){
         this.clientIdSet = clientId;
         this.emailSet = email;
         this.firstNameSet = firstName;
         this.lastNameSet = lastName;
         this.products = [];
    }

    set clientIdSet(clientId){
        let clientRegex = /^[0-9]{6}$/g;
        if(clientId.match(clientRegex)){
            this.clientId = clientId;
        }
        else{
            throw new TypeError('Client ID must be a 6-digit number');
        }
    }

    set emailSet(email){
        let emailRegex = /^[a-zA-Z0-9]+\@[a-zA-Z]+(\.[a-zA-Z]+)+$/g;
        if(email.match(emailRegex)){
            this.email = email;
        }
        else{
            throw new TypeError('Invalid e-mail');
        }
    }

    set firstNameSet(firstName){
        if(firstName.length < 3 || firstName.length > 20){
            throw new TypeError('First name must be between 3 and 20 characters long');
        }

        let nameRegex = /^[a-zA-Z]{3,20}$/g;
        if(firstName.match(nameRegex)){
            this.firstName = firstName;
        }
        else{
            throw new TypeError('First name must contain only Latin characters');
        }
    }

    set lastNameSet(lastName){
        if(lastName.length < 3 || lastName.length > 20){
            throw new TypeError('Last name must be between 3 and 20 characters long');
        }

        let nameRegex = /^[a-zA-Z]{3,20}$/g;
        if(lastName.match(nameRegex)){
            this.lastName = lastName;
        }
        else{
            throw new TypeError('Last name must contain only Latin characters');
        }
    }
}
