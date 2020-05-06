let allItemsIncomplete = true

const pageTitle = 'My Shopping List';

const groceries = [
  { id: 1, name: 'Oatmeal', completed: false },
  { id: 2, name: 'Milk', completed: false },
  { id: 3, name: 'Banana', completed: false },
  { id: 4, name: 'Strawberries', completed: false },
  { id: 5, name: 'Lunch Meat', completed: false },
  { id: 6, name: 'Bread', completed: false },
  { id: 7, name: 'Grapes', completed: false },
  { id: 8, name: 'Steak', completed: false },
  { id: 9, name: 'Salad', completed: false },
  { id: 10, name: 'Tea', completed: false }
];
// add pageTitle
function setPageTitle() {
  const TitleElement = document.getElementById('title');
  TitleElement.innerText = pageTitle;
  //PageTitle.querySelector('.name').innerText=name;
}

function displayGroceries() {
  const ul = document.querySelector('ul');
  groceries.forEach((item) => {
    const li = document.createElement('li');
    li.innerText = item.name;
    li.setAttribute('class', 'test')
    const checkCircle = document.createElement('i');
    checkCircle.setAttribute('class', 'far fa-check-circle');
    li.appendChild(checkCircle);
    ul.appendChild(li);
  });
}
// Don't worry too much about what is going on here, we will cover this when we discuss events.
document.addEventListener('DOMContentLoaded', () => {
  // When the DOM Content has loaded attach a click listener to the button
  setPageTitle();
  displayGroceries();

  //const button = document.querySelector('.btn');
  //button.addEventListener('click', markCompleted);

  const completeItem = document.querySelectorAll('li')
  completeItem.forEach((grocery) => {
    grocery.addEventListener('click', () => {
      if (!grocery.classList.contains('completed')) {
        grocery.classList.add('completed')
        //grocery.setAttribute('class','completed')
        let currentClassList = grocery.querySelector('i').getAttribute('class');
        grocery.querySelector('i').setAttribute('class', currentClassList + ' ' + 'completed')
        //grocery.querySelector('i').classList.add('completed')

      }
    })
    grocery.addEventListener('dblclick', () => {
      if (grocery.classList.contains('completed')) {
        grocery.classList.remove('completed')

        grocery.querySelector('i').classList.remove('completed')
      }
    })

    


})

const completeAll = document.getElementById('toggleAll')
    completeAll.addEventListener('click', () => {
      completeItem.forEach((item) => {
        if (allItemsIncomplete) {

          item.classList.add('completed')
          item.querySelector('i').classList.add('completed')
          let toggleButton = document.getElementById('toggleAll');
          toggleButton.innerText = 'Mark All Incomplete'


        }
        else {
          item.classList.remove('completed')
          item.querySelector('i').classList.remove('completed')
          let toggleButton = document.getElementById('toggleAll');
          toggleButton.innerText = 'Mark All Complete'

        }


      })
      allItemsIncomplete = !allItemsIncomplete;
    })
  })


