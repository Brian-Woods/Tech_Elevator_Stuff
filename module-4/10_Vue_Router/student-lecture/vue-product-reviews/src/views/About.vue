<template>
  <div class="about">
    <h1> About the author</h1>
    <author-bio />
  </div>
</template>

<script>
import AuthorBio from "@/components/AuthorBio.vue"
export default {
  name: 'about',
  components:{
    AuthorBio
  }

}
</script>

<style>

</style>