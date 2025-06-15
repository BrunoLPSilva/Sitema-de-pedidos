import { Component } from '@angular/core';
import { PedidoService } from 'src/app/core/services/pedido.service';
import { Pedido } from 'src/app/core/models/pedido.model';
import { Router } from '@angular/router';


@Component({
  selector: 'app-criar-pedido',
  templateUrl: './criar-pedido.component.html',
  styleUrls: ['./criar-pedido.component.scss']
})
export class CriarPedidoComponent {
  cliente: string = '';
  status: string = 'Pendente'; // valor padrão
  itens: any[] = [
    { nomeProduto: '', quantidade: 1, precoUnitario: 0 }
  ];

  constructor(private pedidoService: PedidoService, private router: Router) {}

 enviarPedido(pedido: Pedido) {
  this.pedidoService.criarPedido(pedido).subscribe({
    next: () => {
      alert('Pedido criado com sucesso!');
      this.router.navigate(['']); //Para redirecionar para a lista
    },
    error: (err) => {
      console.error('Erro ao criar pedido:', err);
      alert('Erro: ' + (err?.error?.message || 'Erro desconhecido'));
    }
  });
}

}


