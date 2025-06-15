import { Component, Output, EventEmitter } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'pedido-form',
  templateUrl: './pedido-form.component.html',
  styleUrls: ['./pedido-form.component.scss']
})
export class PedidoFormComponent {

  constructor(private router: Router) {}

  @Output() pedidoCriado = new EventEmitter<any>();
  status: string = 'Pendente';
  cliente: string = '';
  itens: any[] = [{ nomeProduto: '', quantidade: 1, precoUnitario: 0 }];

  adicionarItem() {
    this.itens.push({ nomeProduto: '', quantidade: 1, precoUnitario: 0 });
  }

  removerItem(index: number) {
    this.itens.splice(index, 1);
  }

  criarPedido() {
    const pedido = {
      cliente: this.cliente,
       status: this.status,
      itens: this.itens
    };
    this.pedidoCriado.emit(pedido);
  }

   irParaHome() {
    this.router.navigate(['']); // redireciona para rota raiz
  }
}
