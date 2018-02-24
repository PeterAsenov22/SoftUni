let solution = (function () {

    function call(post, action) {
        if(action == 'upvote'){
            post.upvotes += 1;
        }
        else if(action == 'downvote'){
            post.downvotes += 1;
        }
        else if(action == 'score'){
            let upvotes = post.upvotes;
            let downvotes = post.downvotes;

            if(upvotes + downvotes > 50){
                let biggerNum = Math.max(upvotes,downvotes);
                upvotes += Math.ceil(biggerNum*0.25);
                downvotes += Math.ceil(biggerNum*0.25);
            }

            let balanceResult = upvotes-downvotes;

            let upvotesPercentage = (post.upvotes*100)/(post.upvotes+post.downvotes);
            let balance = post.upvotes - post.downvotes;
            let rating = '';

            if(post.upvotes + post.downvotes < 10){
                rating = 'new';
            }
            else if(balance<0){
                rating = 'unpopular';
            }
            else if(upvotesPercentage > 66){
                rating = 'hot'
            }
            else if(upvotes > 100 && downvotes > 100){
                rating = 'controversial';
            }
            else {
                rating = 'new';
            }

            return [upvotes,downvotes,balanceResult,rating];
        }
    }

    return {
        call: call
    }
})();
