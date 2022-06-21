<template>
  <div class="home">
    <img alt="Vue logo" src="../assets/logo.png" />
    <button @click="login">Login</button>
  </div>
</template>

<script>
import api from "@/apiService.js";

export default {
  name: "HomeView",
  components: {},
  methods: {
    async login() {
      console.log(await api.get("Pizza"));
    },
  },
};
</script>
