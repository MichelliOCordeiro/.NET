import React, { useEffect } from "react";
import { Typography, Grid, Button } from '@material-ui/core';
import { Box } from "@mui/material";
import './Home.css';
import TabPostagem from "../../components/postagens/tabPostagem/TabPostagem";
import ModalPostagem from "../../components/postagens/modalPostagem/ModalPostagem";
import { Link, useNavigate } from "react-router-dom";
import { useSelector } from "react-redux";
import { TokenState } from "../../store/tokens/tokensReducer";
import Navbar from "../../components/estaticos/navbar/Navbar";
import useLocalStorage from "react-use-localstorage";

function Home() {

    let navigate = useNavigate();
    const [token, setToken] = useLocalStorage('token');
    
    useEffect(() => {
        if (token === '') {
          navigate('/login');
          alert("Você precisa estar logado");
        }
      }, [token, navigate]);

    return (
        <>
            <Grid container direction="row" justifyContent="center" alignItems="center" className='caixa'>
                <Grid alignItems="center" item xs={6}>
                    <Box paddingX={20} alignItems="center">
                        <Typography variant="h3" gutterBottom color="textPrimary" component="h3" align="center" className='titulo'>Blog da Mi</Typography>
                        <Typography variant="h5" gutterBottom color="textPrimary" component="h5" align="center" className='titulo'>Feito para apaixonadas por gatos</Typography>
                    </Box>
                    <Box display="flex" justifyContent="center">
                        <Box marginRight={1}>
                            <ModalPostagem />
                        </Box>
                        <Link to="/postagens" className="text-decorator-none">
                            <Button variant="outlined" className='botao'>Ver Postagens</Button>
                        </Link>
                    </Box>
                </Grid>
                <Grid item xs={6} >
                    <img src="https://i.pinimg.com/236x/66/30/d1/6630d19b6ba72b60cbca56894326b13d--black-white-photography-cat-photography.jpg" alt="Mulher e gato" width="500px" height="500px" />
                </Grid>
                <Grid xs={12} className='postagens'>
                    <TabPostagem />
                </Grid>
            </Grid>
        </>
    );
}

export default Home;