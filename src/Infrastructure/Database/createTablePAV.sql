CREATE TABLE Cliente (
    id_cliente SERIAL PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    cpf_cnpj VARCHAR(20) NOT NULL,
    telefone VARCHAR(20),
    email VARCHAR(100) NOT NULL,
    logradouro VARCHAR(100) NOT NULL,
    numero VARCHAR(20) NOT NULL,
    complemento VARCHAR(100),
    bairro VARCHAR(50) NOT NULL,
    cidade VARCHAR(50) NOT NULL,
    estado VARCHAR(50) NOT NULL,
    cep VARCHAR(20) NOT NULL
);

CREATE TABLE Fornecedor (
    id_fornecedor SERIAL PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    cpf_cnpj VARCHAR(20) NOT NULL,
    telefone VARCHAR(20),
    email VARCHAR(100) NOT NULL,
    logradouro VARCHAR(100) NOT NULL,
    numero VARCHAR(20) NOT NULL,
    complemento VARCHAR(100),
    bairro VARCHAR(50) NOT NULL,
    cidade VARCHAR(50) NOT NULL,
    estado VARCHAR(50) NOT NULL,
    cep VARCHAR(20) NOT NULL
);

create table Classificacao (
	id_classificacao SERIAL primary key,
	nome varchar(80)
);

CREATE TABLE Produto (
    id_produto SERIAL PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    qtd_estoque INTEGER NOT NULL,
    preco NUMERIC(10,2) NOT NULL,
    unidade VARCHAR(20) NOT NULL,
    id_fornecedor INTEGER NOT NULL REFERENCES Fornecedor(id_fornecedor),
    id_classificacao INTEGER NOT NULL REFERENCES Classificacao(id_classificacao)
);

CREATE TABLE FormaPagamento (
    id_forma_pagamento SERIAL PRIMARY KEY,
    nome VARCHAR(50) NOT NULL
);

CREATE TABLE Venda (
    id_venda SERIAL PRIMARY KEY,
    data_hora TIMESTAMP NOT NULL,
    id_cliente INTEGER NOT NULL REFERENCES Cliente(id_cliente),
    total_venda NUMERIC(10,2) NOT NULL,
    situacao_venda VARCHAR(20) NOT NULL
);

CREATE TABLE ItemVenda (
    id_venda INTEGER NOT NULL,
    id_produto INTEGER NOT null,
    qtd_item INTEGER NOT NULL,
    valor_unitario NUMERIC(10,2) NOT NULL,
    total_item NUMERIC(10,2) NOT NULL,
    PRIMARY KEY (id_venda, id_produto),
    FOREIGN KEY (id_venda) REFERENCES Venda(id_venda),
    FOREIGN KEY (id_produto) REFERENCES Produto(id_produto)
);

CREATE TABLE FormaPagamentoVenda (
    id_venda INTEGER NOT NULL,
    id_forma_pagamento INTEGER NOT null references FormaPagamento(id_forma_pagamento),
    valor NUMERIC(10,2) NOT NULL,
    PRIMARY KEY (id_venda, id_forma_pagamento),
    FOREIGN KEY (id_venda) REFERENCES Venda(id_venda)
);

CREATE TABLE FormaPagamentoCompra (
    id_compra INTEGER NOT NULL,
    id_forma_pagamento INTEGER NOT null references FormaPagamento(id_forma_pagamento),
    valor NUMERIC(10,2) NOT NULL,
    PRIMARY KEY (id_compra, id_forma_pagamento),
    FOREIGN KEY (id_compra) REFERENCES Compra(id_compra)
);

insert into formapagamento(nome)
values
	('CREDITO'),
	('DEBITO'),
	('PIX'),
	('ESPECIE');

CREATE TABLE Compra (
    id_compra SERIAL PRIMARY KEY,
    data_hora TIMESTAMP NOT NULL,
    id_fornecedor INTEGER NOT NULL REFERENCES Fornecedor(id_fornecedor),
    total_compra NUMERIC(10,2) NOT NULL,
    situacao_compra VARCHAR(20) NOT NULL
);

CREATE TABLE ItemCompra (
    id_compra INTEGER NOT NULL,
    numero_item SERIAL,
    id_produto INTEGER NOT NULL REFERENCES Produto(id_produto),
    qtd INTEGER NOT NULL,
    valor_unitario NUMERIC(10,2) NOT NULL,
    total_item NUMERIC(10,2) NOT NULL,
    PRIMARY KEY (id_compra, numero_item),
    FOREIGN KEY (id_compra) REFERENCES Compra(id_compra)
);

CREATE TABLE ContaReceber (
    id_conta_receber SERIAL PRIMARY KEY,
    descricao VARCHAR(100),
    id_cliente INTEGER NOT NULL REFERENCES Cliente(id_cliente),
    data_lancamento TIMESTAMP NOT NULL,
    data_vencimento TIMESTAMP NOT NULL,
    valor_recebido NUMERIC(10,2),
    valor_estimado NUMERIC(10,2),
    data_recebimento TIMESTAMP
);

CREATE TABLE ContaPagar (
    id_conta_pagar SERIAL PRIMARY KEY,
    descricao VARCHAR(100),
    id_fornecedor INTEGER NOT NULL REFERENCES Fornecedor(id_fornecedor),
    data_lancamento TIMESTAMP NOT NULL,
    data_vencimento TIMESTAMP NOT NULL,
    valor_pago NUMERIC(10,2),
    data_pagamento TIMESTAMP,
    valor_pagamento NUMERIC(10,2)
);

CREATE TABLE Caixa (
    id_caixa SERIAL PRIMARY KEY,
    saldo NUMERIC(10,2) NOT NULL
);

CREATE TABLE MovimentoCaixa (
    id_caixa INTEGER NOT NULL,
    id_movimento SERIAL,
    data_hora_movimento TIMESTAMP NOT NULL,
    descricao VARCHAR(100) NOT NULL,
    tipo_movimento VARCHAR(20) NOT NULL,
    valor NUMERIC(10,2) NOT NULL,
    PRIMARY KEY (id_caixa, id_movimento),
    FOREIGN KEY (id_caixa) REFERENCES Caixa(id_caixa)
);

insert into caixa(saldo)
values
	(0);

select v.id_venda, v.data_hora, c.nome, p.id_produto, p.nome, i.qtd_item, i.valor_unitario, i.total_item, v.total_venda 
from cliente c
inner join venda v on
c.id_cliente = v.id_cliente 
inner join itemvenda i on
	v.id_venda = i.id_venda 
inner join produto p on
	i.id_produto = p.id_produto
where v.id_venda = $idvenda;

select c.*, iv.*, p.*, v.*
FROM cliente c
INNER JOIN venda v ON 
c.id_cliente = v.id_cliente
INNER JOIN itemvenda iv ON 
v.id_venda = iv.id_venda
INNER JOIN produto p ON 
iv.id_produto = p.id_produto
WHERE v.id_venda = $IdVenda;



