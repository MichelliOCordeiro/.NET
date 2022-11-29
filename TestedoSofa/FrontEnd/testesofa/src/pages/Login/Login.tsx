import React from 'react';
import './Login.css';
import { Grid, TextField, Button, Box, Container } from '@material-ui/core';

function Login() {
    
    return (
        <>
        <Grid container direction='row' justifyContent='center' alignItems='center' className='pagina'>
                <Grid alignItems='center' xs={6}>
                    <Box display='flex' justifyContent='center'>
                        <div className='textos'>
        <h2>Teste do Sofá</h2>
        <h1>Garantindo seu conforto</h1>
        <p> Ajudamos pessoas a se sentirem confortáveis em seus momentos de lazer e descanso.</p>
        </div>
            
        <form className='forma'>     
            <TextField id='usuario' label='usuario' variant='outlined' name='usuario' margin='normal' fullWidth/>
            <TextField id='senha' label='senha' variant='outlined' name='senha' margin='normal' fullWidth/>  
        </form>            
            </Box>

            <Container className='botoes' >
                <Button type='submit' variant='contained' color='default'> Entrar</Button>  
                      
                <Button type='submit' variant='contained' color='default'> Nova Conta </Button>
            </Container>   
            
            </Grid>
            <Grid xs={6}>
            </Grid>
            </Grid>
        </>
);
}

export default Login;