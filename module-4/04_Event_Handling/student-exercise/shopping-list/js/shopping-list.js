let allItemsIncomplete = true;
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

/**
 * This function will get a reference to the title and set its text to the value
 * of the pageTitle variable that was set above.
 */
function setPageTitle() {
  const title = document.getElementById('title');
  title.innerText = pageTitle;
}

/**
 * This function will loop over the array of groceries that was set above and add them to the DOM.
 */
function displayGroceries() {
  const ul = document.querySelector('ul');
  groceries.forEach((item) => {
    const li = document.createElement('li');
    li.innerText = item.name;
    const checkCircle = document.createElement('i');
    checkCircle.setAttribute('class', 'far fa-check-circle');
    li.appendChild(checkCircle);
    ul.appendChild(li);
  });

}


document.addEventListener('DOMContentLoaded', () => {
  setPageTitle();
  displayGroceries();
})

const groceries = document.querySelectorAll('li');

groceryItem.forEach((groceryItem) => {
  groceryItem.addEventListener('click', () => {
    MarkItemComplete(item);
  })
  groceryItem.addEventListener('dblclick', () => {
    MarkItemIncomplete(item);
  })
}

//const completeItem = document.querySelectorAll('li')
//completeItem.forEach((grocery)=>{
 // grocery.addEventListener('click', () =>{
  //  if(!grocery.classlist.contains('completed')){}
 // })
// })
  
  

function MarkItemComplete(element) {
    element.classlist.add("completed");
  }

function MarkItemIncomplete(element) {
    if (element.classlist.contains('completed')) {
      element.classlist.remove('completed');
    }
  }

function MarkAllComplete(element) {
    forEach(element)
    {
      element.classlist.add('completed');
    }
    MarkAllComplete = true;
  }

function MarkAllIncomplete(element) {

    forEach(element)
    {
      if (element.classlist.contains('completed')) {
        element.classlist.remove("completed");
      }
    }
    MarkAllIncomplete = true;

  }



setPageTitle();
displayGroceries();
