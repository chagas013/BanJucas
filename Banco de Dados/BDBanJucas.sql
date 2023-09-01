use BanjucasDsk

create table clientes(
idCliente int identity not null,
nome varchar (50) not null,
cpf char (11) not null unique,
rg char (9),
dataNascimento date not null,
telefone varchar (20),
celular varchar (20) not null,
email varchar (50),
logradouro varchar (75) not null,
numeroLogradouro varchar (5) not null,
cep char (8) not null,
cidade varchar (50) not null,
estado char (2) not null,
genero char (1) not null,
renda numeric (10,2) not null,
senhaLogin char (6) not null,
constraint pk_clientes primary key (idCliente),
);

create table conta(
idConta int identity not null,
idCliente int not null,
statusConta varchar (50) check (statusConta in ('ATIVA', 'INATIVA', 'BLOQUEADA', 'EM ANÁLISE')) not null,
tipoConta varchar (10) not null,
saldo numeric (10,2) not null,
limite numeric (10,2) not null,
dataAbertura datetime not null,
dataEncerramento datetime,
senhaConta char (6) not null,
constraint pk_conta primary key (idConta),
constraint fk_clientes_conta foreign key (idCliente) references clientes (idCliente),
);


create table tipoOperacao(
idTipoOperacao int identity not null,
nomeOperacao varchar (50) not null,
constraint pk_idTipoOperacao primary key (idTipoOperacao)
);

create table movimentacoes(
idMovimentacao int identity not null,
idContaOrigem int not null,
idContaDestino int not null,
idTipoOperacao int not null,
dataHora datetime,
valor numeric (10,2),
constraint pk_idMovimentacao primary key (idMovimentacao),
constraint fk_conta_Origem_movimentacoes foreign key (idContaOrigem) references conta (idConta),
constraint fk_conta_Destino_movimentacoes foreign key (idContaDestino) references conta (idConta),
constraint fk_tipoOperacao_movimentacoes foreign key (idTipoOperacao) references tipoOperacao (idTipoOperacao),
);

create table agendamento(
idAgendamento int identity not null,
idTipoOperacao int not null,
idContaOrigem int not null,
idContaDestino int not null,
valor numeric (10,2) not null,
dataAgendamento datetime not null,
cancelarAgendamento datetime,
statusAgendamento varchar (30) check (statusAgendamento in ('AGENDADO', 'REALIZADO', 'CANCELADO - SEM FUNDO', 'CANCELADO PELO CLIENTE')),
constraint pk_idAgendamento primary key (idAgendamento),
constraint fk_tipoOperacao_agendamento foreign key (idTipoOperacao) references tipoOperacao (idTipoOperacao),
constraint fk_conta_Origem_agendamento foreign key (idContaOrigem) references conta (idConta),
constraint fk_conta_Destino_agendamento foreign key (idContaDestino) references conta (idConta),
);

drop table agendamento
drop table movimentacoes
drop table tipoOperacao
drop table conta
drop table clientes



insert into clientes 
values ('Cauã Chagas', '37418657889', null, '04/13/1991', null, '13982274787', 'caua.schagas@gmail.com', 'Rua João Ramalho', '648', '11702820', 'Praia Grande', 'SP', 'M', '3000', '130491');

create procedure ps_validaLogin
@cpf char(11),
@senhaLogin char(6)
as
select * from clientes
where cpf = @cpf and senhaLogin = @senhaLogin

exec ps_validaLogin '37418657889', '130491'


select * from clientes
select * from conta

insert into conta
values (1, 'ATIVA', 'Corrente', '15000.00', '3750.00', '08/10/2023', null, '123456');

create procedure ps_buscaContasPorIdCliente
@idCliente int
as
select * from conta
where idCliente = @idCliente

exec ps_buscaContasPorIdCliente 1

/* Cadastrar correntista*/

create procedure pi_cadastroCliente
@nome varchar(50),
@cpf char(11),
@rg char(9),
@dataNascimento datetime,
@telefone varchar(20),
@celular char(11),
@email varchar(50),
@logradouro varchar(75),
@numeroLogradouro varchar(5),
@cep char(8),
@cidade varchar(60),
@estado char(2),
@genero char(1),
@renda numeric(10,2),
@senhaLogin char(6)

as
insert into clientes
values (@nome, @cpf, @rg, @dataNascimento, @telefone, @celular, @email, @logradouro, @numeroLogradouro, @cep, @cidade, @estado, @genero, @renda, @senhaLogin)

exec pi_cadastroCliente 'Lucas Lima', '12345678900', null, '07/09/1990', null, '13991234567', null, 'Vila Belmiro', '10', '11000000', 'Santos', 'SP', 'M', '400000.00', '101010'

