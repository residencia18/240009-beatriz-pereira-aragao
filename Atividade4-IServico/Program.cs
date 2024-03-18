
using Atividade4_IServico;
using Atividade4_IServico.Interfaces;
using Atividade4_IServico.Entities;

ServicoFabrica<ServicoTeste> fabrica = new ServicoFabrica<ServicoTeste>();

ServicoTeste servico = fabrica.NovaInstancia();
servico.Executar();
