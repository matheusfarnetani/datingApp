import { Component, inject, OnInit } from '@angular/core';
import { MembersService } from '../../_services/members.service';
import { IMember } from '../../_models/IMember';
import { MemberCardComponent } from "../member-card/member-card.component";

@Component({
  selector: 'app-member-list',
  imports: [MemberCardComponent],
  templateUrl: './member-list.component.html',
  styleUrl: './member-list.component.css'
})
export class MemberListComponent implements OnInit {
  private memberService = inject(MembersService);
  members: IMember[] = [];

  ngOnInit() {
    this.loadMembers();
  }

  loadMembers() {
    this.memberService.getMembers().subscribe({
      next: members => this.members = members
    })
  }
}
