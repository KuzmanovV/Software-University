


export function updateCreatedPostsView(mainSection, wantedElement){
mainSection.replaceChildren(wantedElement);
}


export function updateHomeView(...children){
const body = document.querySelector('body');
body.replaceChildren(...children)
}