import { Component, Input, OnChanges, SimpleChanges } from '@angular/core';
import { Router } from '@angular/router';
import { Pedido } from 'src/app/core/models/pedido.model';

@Component({
  selector: 'app-pedido-list',
  templateUrl: './pedido-list.component.html',
  styleUrls: ['./pedido-list.component.scss']
})
export class PedidoListComponent implements OnChanges {
  @Input() pedidos: any[] = [];
  pedidosFiltrados: any[] = [];
  statusFiltro: string = '';

  constructor(private router: Router) {}

  ngOnChanges(changes: SimpleChanges) {
    if (changes['pedidos']) {
      this.pedidosFiltrados = [...this.pedidos];
      this.filtrarPedidos();
    }
  }

  filtrarPedidos() {
    if (!this.statusFiltro) {
      // Se vazio, mostra todos
      this.pedidosFiltrados = [...this.pedidos];
    } else {
      this.pedidosFiltrados = this.pedidos.filter(pedido => pedido.status === this.statusFiltro);
    }
  }

  calcularTotal(pedido: any): number {
    return pedido.itens.reduce((soma: number, item: any) => soma + item.quantidade * item.precoUnitario, 0);
  }

  editarPedido(pedido: Pedido) {
    console.log('Editar pedido:', pedido);
    this.router.navigate([`/pedidos/${pedido.id}/status`]);
  }
}
