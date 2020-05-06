let shoppingList =[];

function loadGroceries(){
    console.log('load groceries');
    //fetch('assets/data/shopping-list.json')
    fetch('https://localhost:44322/api/groceries')    
    .then((response) =>{

        return response.json()
    })

    .then((data) =>{
        shoppingList = data;
        displayGroceries();
        const button = document.querySelector('.loadingButton')
        button.removeEventListener('click', loadGroceries);
    })

    .catch((err) =>{console.error(err)})
    console.log("finished loading groceries");
}

document.addEventListener('DOMContentLoaded', () =>{
    
    const button = document.querySelector('.loadingButton')

    button.addEventListener('click', loadGroceries)

    //const listItemButton = document.querySelector('.far fa-check-circle')
})

function displayGroceries(){
    if('content' in document.createElement('template'))
    {
        const container = document.querySelector('ul')

        shoppingList.forEach((listItem) =>{

            const tmpl = document.getElementById('shopping-list-item-template').content.cloneNode(true);    
            
            tmpl.querySelector('li').insertAdjacentHTML("afterbegin",listItem.name) 
            
            if(listItem.completed)
            {
                const circleCheck = tmpl.querySelector('.fa-check-circle')
                circleCheck.classList.add('completed')
            }
           
            //tmpl.querySelector('.far fa-check-circle'.appendChild) = listItem.completed;
            
            container.appendChild(tmpl);
           
        }) ; 
    }else {
        console.error('Your browser does not support templates');
      }

    }
