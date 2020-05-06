<template>
  <div class="user-profile">
      <router-link to="/users"> Back to Users List </router-link>
      <h1>User</h1>
      <pre>{{user}}</pre>
  </div>
</template>

<script>
import userService from "@/service/UserService"

export default {
    name: 'user-profile',
    data() {
        return {
            user: null
        }
    },
    methods: {
        getUser(id){
            userService.get(id).then(user => this.user = user);
        }
    },
    created() {
        //this.$route is available in 
        this.getUser(this.$route.params.id);
    }

}
</script>

<style>

</style>