function extract(idString) {
        let text = document.getElementById(idString).textContent;
        let regex = /\((.+?)\)/g;
        let matches = [];
        while (match = regex.exec(text)){
            matches.push(match[1]);
        }

        return matches.join('; ');
    }
