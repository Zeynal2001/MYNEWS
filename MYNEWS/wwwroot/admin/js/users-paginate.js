let pageSize = document.getElementById('pageSize');

pageSize.addEventListener('change', () => {
    window.location = 'https://localhost:7191/admin_panel/Users/GetAllUsers?pageSize=${pageSize.value}';
})