


const showSidebar = () =>
{
    const sidebar = document.querySelector('.sidebar')
    sidebar.style.display = 'flex'

}

const hideSidebar = () => {
    const sidebar = document.querySelector('.sidebar')
    sidebar.style.display = 'none'
}


const activePage = window.location.pathname;
const navLinks = document.querySelectorAll('nav a').forEach(link => {
    if (link.href.includes(`${activePage}`)) {
        console.log(`${activePage}`);
    }
})


