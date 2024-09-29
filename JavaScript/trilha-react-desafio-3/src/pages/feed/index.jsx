import react from 'react';
import { card } from "../../components/Card";
import { UserInfo} from "../../components/UserInfo";

import { Header } from "../../components/Header";

import { Container, Column, Title, TitleHighLight } from './styles';

const Feed = () => {
    return (<>
        <Header autenticado={true}/>
        <Container>
            <Column flex={3}>
                <Title>Feed</Title>
                {/* <Card />
                <Card />
                <Card />
                <Card />
                <Card />
                <Card />
                <Card />
                <Card />
                <Card />
                <Card /> */}
            </Column>
            <Column flex={1}>
                <TitleHighLight># RANK 5 TOP DA SEMANA</TitleHighLight>
                <UserInfo percentual={90} nome="Sílvio Luiz" image="https://avatars.githubusercontent.com/u/20261830?v=4" />
                <UserInfo percentual={80} nome="Sílvio Luiz" image="https://avatars.githubusercontent.com/u/20261830?v=4" />
                <UserInfo percentual={60} nome="Sílvio Luiz" image="https://avatars.githubusercontent.com/u/20261830?v=4" />
                <UserInfo percentual={75} nome="Sílvio Luiz" image="https://avatars.githubusercontent.com/u/20261830?v=4" />
            </Column>
        </Container>

    </>)
}

export { Feed };