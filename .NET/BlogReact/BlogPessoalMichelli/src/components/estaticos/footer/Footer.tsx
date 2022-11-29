import React from 'react';
import InstagramIcon from '@material-ui/icons/Instagram';
import FacebookIcon from '@material-ui/icons/Facebook';
import LinkedInIcon from '@material-ui/icons/LinkedIn'
import GitHubIcon from '@material-ui/icons/GitHub';
import { Typography, Grid } from '@material-ui/core'
import { useSelector } from 'react-redux';
import { TokenState } from '../../../store/tokens/tokensReducer';
import { Box } from "@mui/material";
import useLocalStorage from 'react-use-localstorage';

function Footer() {

    const [token, setToken] = useLocalStorage('token');

    var footerComponent;

    if (token !== '') {
        footerComponent = <Grid container direction="row" justifyContent="center" alignItems="center">
            <Grid alignItems="center" item xs={12}>
                <Box style={{ backgroundColor: "#3F51B5", height: "90px" }}>
                    <Box paddingTop={1} display="flex" alignItems="center" justifyContent="center">
                        <Typography variant="h5" align="center" gutterBottom style={{ color: "black" }}>Me segue nas redes sociais </Typography>
                    </Box>
                    <Box display="flex" alignItems="center" justifyContent="center">
                        <a href="https://www.facebook.com/" target="_blank">
                            <FacebookIcon style={{ fontSize: 40, color: "black" }} />
                        </a>
                        <a href="https://www.instagram.com/mimi.cordeiro/" target="_blank">
                            <InstagramIcon style={{ fontSize: 40, color: "black" }} />
                        </a>
                        <a href="https://www.linkedin.com/in/michellicordeiro/" target="_blank">
                            <LinkedInIcon style={{ fontSize: 40, color: "black" }} />
                        </a>
                        <a href="https://github.com/MichelliOCordeiro" target="_blank">
                            <GitHubIcon style={{ fontSize: 40, color: "black" }} />
                        </a>
                    </Box>
                </Box>
                <Box style={{ backgroundColor: '#3F51B5', height: "60px" }}>
                    <Box paddingTop={1}>
                        <Typography variant="subtitle2" align="center" gutterBottom style={{ color: "black" }} >© 2022 Copyright: Michelli Cordeiro</Typography>
                    </Box>
                    <Box>
                        <a target="_blank" href="https://brasil.generation.org">
                            <Typography variant="subtitle2" gutterBottom style={{ color: "black" }} align="center">brasil.generation.org</Typography>
                        </a>
                    </Box>
                </Box>
            </Grid>
        </Grid>
    }
    return (
        <>
            {footerComponent}
        </>
    )
}

export default Footer;