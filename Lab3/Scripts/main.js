
function scrollToMain() {
    
    var mainBlock = document.getElementsByClassName('general-Block');    
    mainBlock[0].scrollIntoView({ behavior: 'smooth', block: 'start' });
}

function showSocialsResponsive() {
    var socialsBlock = document.getElementById('socials-To-Make-Responsive');
    var findUsText = document.getElementById('find-Us');

    if(socialsBlock.className === 'socials') {
        socialsBlock.className +='-From-Burger';
        socialsBlock.classList.add('fade');
        setTimeout(() => {
            socialsBlock.className = 'socials-From-Burger';
        },100)
        findUsText.className +='-Responsive';
    } else {
        socialsBlock.className ='socials';
        
        findUsText.className = 'find-Us';
    }
}
    
function expandHeader() {
    var marketAndTrade = document.getElementById('market-And-Trade-Responsive');

    if(marketAndTrade.className === 'market-And-Trade-Profile-Wrapper') {
        marketAndTrade.className += '-Responsive';
    } else {
        marketAndTrade.className = 'market-And-Trade-Profile-Wrapper';
    }
}

function rotateCircles(nameOfClass) {
    console.log('fuck1');

    Array.prototype.forEach.call(circlesToRotate = document.getElementsByClassName(nameOfClass), element => {
         element.className+=" rotated-Circle";
         console.log('fuck from rotating');
    })

    setTimeout((circlesToRotateBack = document.getElementsByClassName('rotated-Circle')) => {
        for(let index = circlesToRotateBack.length-1; index >= 0;index-- ) {
            let temp = circlesToRotateBack[index].className.replace('rotated-Circle','');
            circlesToRotateBack[index].className = temp;    
        }
    }, 1000);
    
    console.log('fuck2');
}

function fadeBody() {
    console.log('fuck');
    document.body.className = 'fade';
    
    setTimeout(() => {
        document.body.className = '';
    },300);
}

//function makePlaneToFly() {
//    var plane = document.getElementById('plane-To-Fly');    
//    var rectanglePlane = plane.getBoundingClientRect();
//    console.log('top: ' + rectanglePlane.top + ' left: ' + rectanglePlane.left);

    
//    var slide = document.getElementById('start-Of-Chapter');
//    var rectangleSlide = slide.getBoundingClientRect();
//    console.log('top: ' + rectangleSlide.top + ' right: ' + rectangleSlide.right);


//    // for (let index = 0; index < 10; index++) {
//    //     setTimeout(()=>{
//    //         plane.style.left = rectanglePlane.left+index+'px';
//    //         plane.style.top = rectanglePlane.top+index+'px'; 
//    //         console.log('top: ' + plane.top + ' right: ' + plane.right);
//    //     },1000);
        
//    // }
//    let pos = 0;
//    var id = setInterval(frame, 5);
//    function frame() {
//    if (pos == rectangleSlide.right-rectanglePlane.left) {
//      clearInterval(id);
//    } else {
//      pos++; 
//      plane.style.top = pos - "px"; 
//      plane.style.left = pos + "px"; 

//      console.log(rectangleSlide.righ-plane.left);
//    }
//  }
//    // var rightOfPlane = rectanglePlane.right;

//    // for (let index = rectanglePlane.left; index < rectangleSlide.left; index++) {
        
        
//    // }

//    // var counter = 1;
//    // for (let index = rightOfPlane; index < rectangleSlide.right; index++){
//    //     setTimeout(()=>{
//    //         plane.style.top = rectanglePlane.top+counter+"px";
//    //         plane.style.left = index - rectanglePlane.left+counter+"px";
//    //     },1000);    

//    //     console.log('fuck');
//    // }

    
    
//}

function rotateSquare() {
    var square = document.getElementById('square-To-Rotate');

    square.addEventListener('mouseover',()=> {
        // while (true) {
            this.classList.add('.rotated-Square-Mouse-Over');
        
    },false);
}
