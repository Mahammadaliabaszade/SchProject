 const setDropdown = document.querySelector(".set-drop")
 const rotate = document.querySelectorAll(".drop")


 

 setDropdown.addEventListener("click", ()=>{
     const active = document.querySelector("#set-dropdown")
     active.classList.toggle("open-dropdown")
 })

 for (let i = 0; i < rotate.length; i++) {
     rotate[i].addEventListener("click",()=>{
        rotate[i].classList.toggle("rotate")
     })
    
 }
const downArrow = document.querySelectorAll("#down-arrow")

for (let i = 0; i < downArrow.length; i++) {
    downArrow[i].addEventListener("click", ()=>{
        const subDropdown = document.querySelectorAll(".dashboard-dropdown-menu ")
        subDropdown[i].classList.toggle("active")
      
    })
    
    
}