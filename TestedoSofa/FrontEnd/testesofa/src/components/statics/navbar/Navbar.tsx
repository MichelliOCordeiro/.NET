import React from 'react';
import { Link, useNavigate } from "react-router-dom";
import './Navbar.css';

function Navbar() {
    function goLogout() {
        setToken('')
        setId('')
        alert("Usuário deslogado")
        navigate('/login')
    }

    var navbarComponent;

    <Box display="flex" justifyContent="start">
                    <Link to="/home" className="text-decorator-none">
                        <Box mx={1} className='cursor'>
                            <Typography variant="h6" color="inherit">
                                Home
                            </Typography>
                        </Box>
    
    return (
        <>


        
        </>
    );
}
export default Navbar;