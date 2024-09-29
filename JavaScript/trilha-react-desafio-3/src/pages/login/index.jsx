import { useNavigate } from "react-router-dom";
import { MdEmail, MdLock } from "react-icons/md";
import { Button } from "../../components/Button";
import { Header } from "../../components/Header";
import { Input } from "../../components/Input";
// import { yupResolver } from '@hookform/resolvers/yup';
// import * as yup from "yup";
import { api } from '../../services/api';

import { useForm } from 'react-hook-form';

import { Column, Container, CriarText, ErrorText, EsqueciText, Row, SubtitleLogin, Title, TitleLogin, Wrapper } from './styles';

// const schema = yup.object({
//     email : yup.string().email().required('Campo Obrigatório'),
//     oassword: yup.string().min(3, 'No mínimo três caracteres!').required('Campo Obrigatório'),
// }).required();

const Login = () => {

    const navigate = useNavigate()

    const { control, register, handleSubmit, watch, formState: { errors, isValid } } = useForm({
        reValidateMode: 'onChange',
        mode: 'onChange',
    });

    const onSubmit = async (formData) => {
        try{
            const { data } = await api.get(`/users?email=${formData.email}&senha=${formData.senha}`);
            if(data.lenght && data[0].id){
                navigate('/feed')
                return;
            }
            
            alert('Email ou senha inválidos.')
            
        } catch(e){
            // TODO Houve um erro
            alert('Houve um erro, tente novamente.')
        }
    };

    console.log('errors', errors);

    // const onSubmit = data => console.log(data);
    // const handleClickSignIn = () => {
    //     navigate('/feed')
    // }

    return (<>
        <Header />
        <Container>
            <Column>
                <Title>
                    A plataforma para você aprender com experts, dominar as principais tecnologias e entrar mais rápido nas empresas mais desejadas.
                </Title>
            </Column>
            <Column>
                <Wrapper>
                    <TitleLogin>Faça seu cadastro</TitleLogin>
                    <SubtitleLogin>Faça seu login e make the change._ </SubtitleLogin>
                    <form onSubmit={handleSubmit(onSubmit)}>
                        <Input placeholder="E-mail" leftIcon={<MdEmail />} name="email" control={control} />
                        {errors.email && <span>Email é obrigatório</span>}
                        <Input placeholder="Senha" type="password" leftIcon={<MdLock />} name="senha" control={control} />
                        {errors.senha && <span>Email é obrigatório</span>}
                        <Button title="Entrar" variant="secondary" type="submit" />
                    </form>
                    <Row>
                        <EsqueciText>Esqueci minha senha</EsqueciText>
                        <CriarText>Criar Conta</CriarText>
                    </Row>
                </Wrapper>
            </Column>
        </Container>
    </>)
}

export { Login }